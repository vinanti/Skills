function Calculator1(number1: number, number2 : number, operator? : string) : number
{
    switch(operator)
    {
        case "-" :
            return number1 - number2;
        case "/" :
            return number1 / number2;
        case "*" :
            return number1 * number1;
        default :
            return add(number1, number2);
    }
}
function add(number1 : number, number2 : number) : number
{
    return number1 + number2;
}
console.log(Calculator1(1,3,"+"));
console.log(Calculator1(1,3));