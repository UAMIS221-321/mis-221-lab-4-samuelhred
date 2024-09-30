Random random = new Random();
string choice = "";
while(choice != "4"){
    System.Console.WriteLine("What would you like to order? \n1. Plain Slice \n2. Cheese Slice \n3. Pepperoni Slice\n4. Exit");
    choice = System.Console.ReadLine();
    switch(choice){
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepperoniPizza();
            break;
        case "4":
            System.Console.WriteLine("Bye!");
            break;
        default:
            System.Console.WriteLine("Invalid Input");
            Pause();
            break;
    }
}
//Plain Pizza
void PlainPizza(){
    int iLim = random.Next(8,12);
    int second = iLim;
    for(int i = iLim; i > 0; i--){
        for(int j = second; j >0; j--){
            System.Console.Write("*\t");
            
        }
        second = second - 1;
        System.Console.WriteLine();
        System.Console.WriteLine();
        
    }
}
//Cheese Pizza
void CheesePizza(){
    int iLim = random.Next(8,12);
    int second = iLim;
    for(int i = iLim; i > 0; i--){
        for(int j = second; j >0; j--){
            if(i == iLim || j == iLim || j == 1 || j == second){
                System.Console.Write("*\t");
            }
            else{
                System.Console.Write("#\t");
            }
        }
        second = second - 1;
        System.Console.WriteLine();
        System.Console.WriteLine();
        
    }
}

//Pepperoni pizza
void PepperoniPizza(){
    int iLim = random.Next(8,12);
    int second = iLim;
    int pep;
    for(int i = iLim; i > 0; i--){
        for(int j = second; j >0; j--){
            if(i == iLim || j == iLim || j == 1 || j == second){
                System.Console.Write("*\t");
            }
            else{
                pep = random.Next(1,5);
                if(pep == 3){
                    System.Console.Write("[]\t");
                }
                else{
                    System.Console.Write("#\t");
                }
                
            }
        }
        second = second - 1;
        System.Console.WriteLine();
        System.Console.WriteLine();
        
    }
}

//pause

static void Pause(){
    System.Console.WriteLine("Press any key to continue...");
    System.Console.ReadKey();
    System.Console.Clear();
}