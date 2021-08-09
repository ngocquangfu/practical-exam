#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>


int main() {
  system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
int a[100];
int i=0;
int j=0;
for( i=0;i<5;i++){
	scanf("%d",&a[i]);
}
  int temp=a[0];
  	for(i= 0; i < 4; i++) {
		for(j = i+2; j < 5; j++) {
			if(a[i] > a[j]) {
			 temp = a[i];

			}
		}
	}
  
  
  
  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:
for(i=0;i<5;i++){
	printf("%d ",a[i]-a[i]);
}







  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
