const boton = document.getElementById("boton")
const user = document.getElementById("username")
const password = document.getElementById("password")

boton.addEventListener('click', (func) =>{

    func.preventDefault() //prevee que no recargue la pagina cuando le doy al boton login

    const data = {  //cree un objeto para validar el usuario y contraseña
        password: password.value,
        username: username.value
    }
    console.log(data) //comprobacion en consola sobre el funcionamiento
})