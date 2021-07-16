//Implement interface as a type
interface IAPIrespose {
    name : string,
    account : number
    mobile? : number
}

function APIRespose(apidata : IAPIrespose) : IAPIrespose
{
    return apidata
}

APIRespose({
    name : "Vinanti",
    account : 23123
})

//Interface implemetation
//interface ICalculator {
//    add(num1 : number, num2 : number) : number
//    substract?(num1 : number, num2 : number) : number
//    divide?(num1 : number, num2 : number) : number
//    multiply?(num1 : number, num2 : number) : number
//}

//class Calculator implements ICalculator {
//    add(num1 : number, num2 : number){
//        return num1 + num2;
//    }
//}