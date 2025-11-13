#include <stdio.h>
main()
{
	int num,status;
	char * cmd[]={"ls","-l","-i",NULL};
	char * cmd2[]={"cal","2010",NULL};

	num=fork();
	if (num!=0)
	{
		wait(&status);
		printf("father\n");
		execv("/bin/ls",cmd);
	}
	else
	{
		printf("child\n");
		execvp("cal",cmd2);
	}
}
