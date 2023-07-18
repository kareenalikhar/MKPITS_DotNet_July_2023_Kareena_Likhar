#include<stdio.h>
void main()
{
	char customer_name[10],product_name[10];
	int price,quantity,total_amount,discount;
	printf("enter customer name:");
	scanf("%s",&customer_name);
	printf("enter product name:");
	scanf("%s",&product_name);
	printf("price:");
	scanf("%d",&price);
	printf("quantity:");
	scanf("%d",&quantity);
	printf("\n");

	total_amount= price*quantity;
	if(total_amount>=1000)
	{
		discount=total_amount*0.40;
	}
	else if(total_amount>=500)
	{
		discount=total_amount*0.25;
	}
	else
	{
    discount=total_amount*0.10;
	}
	printf("customer name:=%s",customer_name);
	printf("\nproduct name:=%s",product_name);
	printf("\nprice=%d",price);
	printf("\nquantity=%d",quantity);
	printf("\ndiscount=%d",discount);
	total_amount=total_amount-discount;
	printf("\ntotal amount=%d",total_amount);
}

//Algorithm
//step1-start
//step2-accept customer name,product name,price,quantity,total amount,discount
//step3-if total amount is greater than 1000 then discount is 40%
//step4-else if total amount is greater than 5000 then discount is 25%
//step5-else discount is 10%
//step6-stop
