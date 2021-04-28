# include <ncurses.h>

int main(int argc, char *argv[])
{
    initscr();    
    noecho();
    keypad(stdscr,TRUE);
    
    int c;
    for(;;) {
	c=getch();
	printf("[%d]\n\r",c);
	refresh();
	if(c=='x') break;
    }
    
    return 0;
}
