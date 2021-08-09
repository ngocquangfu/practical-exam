#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

main()

{
  
 system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
  float a, b, c, p, s=0; // 6 8 9
          printf("");
          scanf("%f", &a);


          



  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:
if((a*a<b*b+c*c) && (b*b<a*a+c*c) && (c*c<b*b+a*a)) {
                   p = (a+b+c)/2;
                   s = sqrt(p*(p-a)*(p-b)*(p-c));
                   printf("%f\n", s);

          }
           else
                   printf("Not a triangle\n");
//--FIXED PART - DO NOT EDIT ANY THINGS HERE
  system ("pause");
  return(0);


}

