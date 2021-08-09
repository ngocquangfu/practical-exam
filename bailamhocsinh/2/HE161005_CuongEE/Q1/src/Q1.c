#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
int isSym(int a[],int n) {
  int i=0;
  int j=0;
	
	for (i=0;i<=n/2;i++) {
		if (a[i]!=a[n-1-i]) return 1;
	}
	return 0;
}

int main() {
  system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
 int i=0;
  int j=0;
    int a[100],n,s=0;
  scanf("%d",&n);
  for (i=0;i<n;i++){
  
  	scanf("%d",&a[i]);}
  

  
  
  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:

if(isSym){
	for( i=0;i<n;i++){
		if(a[i]%2==0){
			s=s+a[i];
		}
		
	}
	if(s==0){
		printf("0");

	}else{ printf("%d",s);

	}
}else{
	printf("0");
}





  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
