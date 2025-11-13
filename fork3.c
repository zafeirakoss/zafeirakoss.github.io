#include <stdio.h>
main()
{
	int i,num;
	if (fork()!=0)
	{
		printf("im the parent.PID=%d,PPID=%d.\n",getpid(),getppid());
		exit(18);
	}
	else
	{
		num=0;
		for (i=1; i<=10000; i++)
			num=num+i;
		sleep(2);
		printf("num is:%d\n",num);
		printf("im the child.PID=%d,PPID=%d.\n",getpid(),getppid());
		exit(20);
	}
	exit(69);
}
