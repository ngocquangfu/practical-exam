#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>


int main() {
  system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
int n;
  int a[100];
  int i=1;
  int j;
  int sum=0;
  scanf("%d",&n);
  while(n!=0){
  	a[i--]=n%10;
  	n/=10;
  }
  
  
  
  
  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:

for(j=i-1;j>0;j--){
	printf("%d",a[j]);
	if(j==1)break;
	printf(",");

}






  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
