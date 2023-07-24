#include<stdio.h>
void main()
{
	int cost_price,selling_price,profit,loss;
	printf("Enter cost price:");
	scanf("%d",&cost_price);
	printf("Enter selling price:");
	scanf("%d",&selling_price);
	profit=selling_price-cost_price;
	loss=cost_price-selling_price;
	if(cost_price<selling_price)
	printf("profit is %d rs",profit);
	else
	printf("loss is %d rs",loss);
}
