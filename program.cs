using System;
class Program {
    static void Main(){
    
        string[] example = {"Heo", "2", "world", ":-)"};
        string[] example2 = {"1234", "1567", "-2", "computer science"};
        string[] example3 = {"Russia", "Denmark", "Kan"};

        string[] Program(string[] words){
            int limit = 3;
            int length = 0;
            for(int i=0; i < words.Length; i++ ){
                if(words[i].Length <= limit ){
                    length++;
                }
            }
     
            string[] result = new string[length];
            int cur = 0;
            for(int i=0; i < words.Length; i++ ){
                if(words[i].Length <= limit ){
                    result[cur] = words[i];
                    cur++;
                }
            }
            
            return result;
      
            // Другое решение, через List
            // List<string> result = new List<string>();
            // int limit = 3;
            // for(int i=0; i < words.Length; i++ ){
            //     if(words[i].Length <= limit ){
            //         result.Add(words[i]);
            //     }
            // }
            // return result.ToArray();
        }

        
        void PrintArray (string[] words){
            for(int i = 0; i<words.Length;i++){
                Console.WriteLine(words[i]);
            }
        }

        Console.WriteLine(example);
        PrintArray( Program(example) );
        Console.WriteLine(example2);
        PrintArray( Program(example2) );
        Console.WriteLine(example3);
        PrintArray( Program(example3) );

    }
}



