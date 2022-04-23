#include<stdio.h>
int main(){
int first[100];
int second[100];
int length, total;
int i,j,k;

	printf("length of vectors : ");
	scanf("%d",&length);

	printf("first vector #1 : ");

	for(i=0;i<length;i++){
	scanf("%d",&first[i]);
}

	printf("second vector #2 : ");

	for(j=0;j<length;j++){
	scanf("%d",&second[j]);
}
	for(k=0;k<length;k++){
	total += first[k]*second[k];
}
	printf("result : %d\n",total);

return 0;
}

