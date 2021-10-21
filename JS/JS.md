# how to declare a empty object
let object = new Object();
let object = {};


# property
let object = {
    key1: "value1", // 
    key2: 34344,    // properties's object 
    key3: true,     // properties's object 
    key4: null,       //  
    "key five": false //
};

# how to show a object
alert(object.key1); //value1
alert(object.key2); //34344

# delete a property
delete object.key1; 

# you cant accede to a property with more than two characters 
alert(object."key five"); // you cant do that 

# you should do this
object["key five"] = "newValue";
alert(object["key five"]);
delete object["key five"];