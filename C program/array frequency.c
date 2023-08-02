#include <stdio.h>
void main() 
{
    int i,j,arr[5],freq[5],count;
    for(i=0;i<5;i++) 
	{
        printf("Enter number: ");
        scanf("%d",&arr[i]);
        freq[i]=-1;
    }

    for(i=0;i<5;i++) 
	{
        count=1;
        for(j=i+1;j<5;j++) 
		{
            if(arr[i]==arr[j]) 
			{
                count++;
                freq[j]=0;
            }
        }
        if(freq[i]!=0) 
		{
            freq[i]=count;
        }
    }
    printf("\nFrequency of elements:\n");
    for(i=0;i<5;i++) 
	{
        if (freq[i]!=0) 
		{
            printf("%d occurs %d time\n",arr[i],freq[i]);
        }
    }
}

//Algorithm:
//1)start
//2)declare i,j,arr[5],freq[5],count
//3)for i=0;i<5;i++
//4)accept num
//5)freq[i]=-1
//6)for i=0;i<5;i++
//7)count=1
//8)for j=i+1;j<5;j++
//9)if arr[i]==arr[j]
//10)count++
//freq[j]=0
//11)if freq[i]!=0
//freq[i]=count
//12)print frequency of element
//13)for i=0;i<5;i++
//14)if freq[i]!=0
//15)print num occur num time
//16)stop


