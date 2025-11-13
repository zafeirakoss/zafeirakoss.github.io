#include <stdio.h>
main()
{
	int status;
	if (fork()!=0)
	{
		wait(&status);
		printf("father here\n");
	}
	else
	{
		if (fork()!=0)
		{
			wait(&status);
			printf("child here\n");
			sleep(1);
		}
		else
		{
			printf("grandchild here\n");
			sleep(1);
		}
	}
	exit(69);
}
