#include <stdio.h>
main()
{
	if (fork()!=0)
	{
		while(1)
			sleep(3);
	}
	else
	{
		printf("im the child.PID%d,PPID=%d.\n",getpid(),getppid());
		exit(102);
	}
}
