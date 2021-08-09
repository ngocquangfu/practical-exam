#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>


int main() {
  system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
	int a[100];
	int b[7];
	int c;
	int i=0;
	int j=0;
	for(i=0;i<7;i++){
		scanf("%d",&a[i]);
	}
	for(i=0;i<6;i++){
	for(j=i+1;j<7;j++){
		if(a[i]<a[j]){
			c=a[j];
			a[j]=a[i];
			a[i]=c;
		}
	}
	}
		for(i=0;i<7;i++){
		b[i]=0;
		if(a[i]>99&&a[i]<1000){
			for(j=0;j<7;j++){
				if(a[i]==a[j]){
					
				b[i]=b[i]+1;
				}
				
			}
		
		}
	}
	int max=b[0];
	for(i=0;i<7;i++){
		if(max<b[i]){
			max=b[i];
		}
	}
  
  
  
  
  
  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:

for(i=0;i<7;i++){
	b[i]=0;
	if(a[i]>99&&a[i]<1000){
			for(j=0;j<7;j++){
				if(a[i]==a[j]){
					
				b[i]=b[i]+1;
				}
				
		
	}
	if(b[i]==max&&a[i]!=a[i+1]){
					printf("%d ",a[i]);
				}
}
}


if(max==0)
{
	printf("No three-digit number");
}


  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
