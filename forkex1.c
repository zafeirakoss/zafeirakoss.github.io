#include <stdio.h>
main()
{
	int num;
	num=fork();

	if (num!=0)
	{
		printf("father\n");
		execl("/bin/date","date","+%T",NULL);
		printf("hello");
	}
	else
	{
		printf("child\n");
		execlp("cat","cat","-n","fork1.c",NULL);
		printf("hello");
	}
}
