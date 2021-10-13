<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Calcular distancia recorrida</h1>
    <form onsubmit="return ejercises1()">
        <input type="text" id = "number1">
        <input type="text" id = "number2"><br><br>
        <input type="text" id = "resultado">
        <input type="button" value="MULTIPLICATE" onclick="ejecises1()">
    </form>
    <script>
        function ejercises1(){
            let v = parseInt(document.getElementById('number1')).value;
            let t = parseInt(document.getElementById('number2')).value;
            let result = v * t;
            p.innerHTML += "the distance travelled was:" + result;
            return false;
        }
        ejercises1();
    </script>
</body>
</html>