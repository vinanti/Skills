var message = function (name) {
    var messageToSend = 'Hello ${name}!!!';
    return 'Hello ${name}!!!';
};
message("Vinanti");
//Data Types understanding
var Name = "Vinanti";
var account = 213131;
var accounts = [232323, 45464, 879];
var accountsMultiDataType = [789789, 456456, "abcds", false];
var isAccountCreated = 5454654; //"dsff" invalid //54656465; // = true (allowed both)
var isUserDeleted = true; //27384 //{} //"yes"
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
    Color[Color["Yello"] = 3] = "Yello";
})(Color || (Color = {}));
;
var carColor = Color.Red; //Color.Yellow invalid //Color.Blue;
