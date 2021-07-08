const message =(name : string)=>{
    const messageToSend : string = 'Hello ${name}!!!'
    return 'Hello ${name}!!!';
}

message("Vinanti")

//Data Types understanding
const Name : string = "Vinanti";
const account : number = 213131;
const accounts : number[] = [232323, 45464, 879]
const accountsMultiDataType : [number, number, string, boolean] = [789789, 456456, "abcds", false]

const isAccountCreated : number | boolean = 5454654   //"dsff" invalid //54656465; // = true (allowed both)

const isUserDeleted : any = true //27384 //{} //"yes"

enum Color {Red, Green, Blue};

const carColor : Color =  Color.Red  //Color.Yellow invalid //Color.Blue;