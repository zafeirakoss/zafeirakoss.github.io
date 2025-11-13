#include <stdio.h>
main()
{
	int status;
	if (fork()!=0)
	{
		wait(&status);
		printf("im the father. PID=%d,PPID=%d\n",getpid(),getppid());
		exit(2);
	}
	else
	{
		printf("im the child. PID=%d,PPID=%d\n",getpid(),getppid());
		if (fork()!=0)
		{
			wait(&status);
			exit(3);
		}
		else
		{
			printf("im the grandchild. PID=%d,PPID=%d\n",getpid(),getppid());
			exit(1);
		}
	}
}
