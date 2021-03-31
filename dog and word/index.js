async function go(){
    const response = await fetch("https://random-word-api.herokuapp.com/word?number=1")
    .then(response => response.json());
    json = response
    console.log(json);
    document.getElementById("word").innerHTML = json;

    image();

}
async function image(){
    const response = await fetch("https://dog.ceo/api/breeds/image/random")
    .then(response => response.json());
    json = response
    console.log(json.message);
    document.getElementById("theImage").innerHTML = `<img src="${json.message}">`;
}