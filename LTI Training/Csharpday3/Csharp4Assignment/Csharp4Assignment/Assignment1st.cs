/*Assignment 1:You are assigned to develop a module to calculate the electricity bill based on below conditions:The standard price per unit is Rs. 1.20.•If number of units are less than 100 then standard price per unit will be applied.
 * 
 * •If it is less than or equal to 300 units then Rs. 2 will be charged for number of units over and above 100 units.
 * •If it is greater 300 units then Rs. 2 will charged for additional 200units above 100 units and Rs. 3 will be charged for additional units above 300.
 * 
 * 
 */
float perunitprice = 1.2f;
float price;
float unit = float.Parse(Console.ReadLine());

if (unit <= 100)
{
    price = perunitprice * unit;
    Console.WriteLine(price);


}

else if (unit <= 300)
{
    price = (100*perunitprice);
    unit = unit - 100;
    float unitprice = 2.0f;
    float total = (unitprice *unit)+ price;
    Console.WriteLine(total);

}
else if(unit>300)
{
    price = (100 * perunitprice)+(200*2.0f);
    unit = unit - 300;
    float unitprice = 3.0f;
    float total = (unitprice * unit) + price;
    Console.WriteLine(total);
}
