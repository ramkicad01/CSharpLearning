class Program{
    static void Main(String[] args){
        Console.WriteLine("Enter the size of Array: ");
        int n = Int32.Parse(Console.ReadLine()); 
        int[] arr = new int[n]; 

        Console.WriteLine("Enter the Array Elements: ");
        for(int i=0; i<n; i++){
            arr[i] = Int32.Parse(Console.ReadLine()); 
        }
        Console.Write("["); 
        for(int i=0; i<n; i++){
            Console.Write((arr[i]).ToString()+" ");
        }
        Console.Write("]"); 
        Console.WriteLine(" "); 
        // Console.WriteLine("THE MAXIMUM VALUE IS: "+ (Maximum(arr))); 
        // Console.WriteLine("THE MINIMUM VALUE IS: "+ (Minimum(arr))); 
        // Console.WriteLine("THE REVERSED STRING IS: "+"[{0}]", string.Join(", ", Reverse(arr)));
        // PrintStar(n); 
        Console.WriteLine("THE DUPLICATE ELEMENTS ARE: "+"[{0}]", string.Join(", ", Duplicate(arr))); 
        Frequency(arr,n); 
    }
    // static int Maximum (int[] arr){
    //     int count = arr[0]; 
    //     for(int i=1; i<arr.Length; i++){
    //         if(arr[i]>count){
    //             count = arr[i]; 
    //         }
    //     }
    //     return count; 
    // }

    // static int Minimum (int[] arr){
    //     int count = arr[0]; 
    //     for(int i=1; i<arr.Length; i++){
    //         if(arr[i]<count){
    //             count = arr[i]; 
    //         }
    //     }
    //     return count; 
    // }
    // static int[] Reverse(int[] arr){
    //     int temp=0; 
    //     int start = 0;
    //     int end = arr.Length-1;
        
    //     while(start<end){
    //         temp = arr[start];
    //         arr[start] = arr[end];
    //         arr[end] = temp; 
    //         start++; 
    //         end--; 
    //     }
    //     return arr; 
    // }

    // static void PrintStar(int n){
    //     for(int i=0; i<n; i++){
    //         for(int j=0; j<=i; j++){
    //             Console.Write("* ");
    //         }
    //         Console.WriteLine(); 
    //     }
    // }

    static int[] Duplicate(int[] arr){
        int n = arr.Length;
        List<int> dups = new List<int>(); 

        for (int i=0; i<n; i++){
            for(int j=i+1; j<n; j++){
               if(arr[i]==arr[j]){
                  dups.Add(arr[j]); 
               }
            }
        }
        return dups.ToArray(); 
    }
    static void Frequency(int[] arr, int n){
        int count=1; 
        for(int i=0; i<n; i++){
            for(int j=i+1; j<n; j++){
                if(arr[i]==arr[j]){
                    count++; 
                }
            }
            if(count>1){
                Console.WriteLine(arr[i]+": "+count+" times"); 
            }
            count = 1; 
        }
    }

    static void LeftRotate(int[] arr){
        
    }

}

