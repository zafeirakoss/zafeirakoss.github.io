#include <stdio.h>
main()
{
	int status;
	if (fork()!=0)
	{
		wait(&status);
		if (fork()!=0)
		{
			wait(&status);
			printf("father here!\n");
		}
		else
		{
			printf("im the second child\n");
			sleep(2);
		}
	}
	else
	{
		printf("im the first child\n");
		sleep(2);
	}
	exit(28);
}
