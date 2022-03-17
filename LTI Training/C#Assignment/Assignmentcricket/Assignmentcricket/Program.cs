Console.WriteLine("How many overs");
int overs = Convert.ToInt32(Console.ReadLine());
int runs,ball1run=0, ball2run=0, ball3run=0, ball4run=0, ball5run=0, ball6run=0;
int sumofruns=0;
int count = 0;


for(int i=0;i<overs;i++)
{ 
      Console.WriteLine("enter over  runs");

        for (int k=0;k<=i;k++)
           {
            


            Console.WriteLine("enter first ball run");
            ball1run = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  seecond  run");
             ball2run = Convert.ToInt32(Console.ReadLine());
             ball3run = Convert.ToInt32(Console.ReadLine());
             ball4run = Convert.ToInt32(Console.ReadLine());
             ball5run = Convert.ToInt32(Console.ReadLine());
             ball6run = Convert.ToInt32(Console.ReadLine());
            sumofruns = sumofruns +ball1run+ball2run+ball3run+ball4run+ball5run+ball6run;
             k = k + 1;
            }
}








float strickRate = 0.0f;
for(int i=0; i<5;i++)
{
    strickRate = (sumofruns / 6.0f)*100;
}
Console.WriteLine("0 Runs: {0} || 1 Runs:{1} || 2 Runs: {2} || 3 Runs : {3} || 4 Runs :{4}, 6 Runs :{5}");
Console.WriteLine("s run: {0}  || total Runs :{1} ||  Straick Rate: {2} ", count, sumofruns, strickRate);
  

