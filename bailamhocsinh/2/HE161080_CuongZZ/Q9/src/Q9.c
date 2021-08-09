#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>


int main() {
  system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
int n;
scanf("%d",&n);
  
  
  int i =0;
  int j=0;
  
  
  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:

for(i=0;i<n;i++){
	for( j=n-i;j>0;j--){
		printf("%d ",n-i);

	}if(i==4){
		break;
	}
	printf("\n");
}



	printf("\n");


  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  system ("pause");
  return(0);
}
