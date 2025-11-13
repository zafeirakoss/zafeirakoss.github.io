#include <stdio.h>
main()
{
	printf("before fork\n");
	printf("PID=%d,PPID=%d\n",getpid(),getppid());
	fork();
	
	printf("after fork.PID=%d,PPD=%d\n",getpid(),getppid());
	exit(69);
	printf("youll never see me");
}
