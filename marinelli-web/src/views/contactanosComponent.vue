<template>
    <div>
        <div class="divCentro">
          <div class="divCabezera">
              <h1 class="titulo">Te proponemos dos formas de contacto para tu comodidad</h1>
          </div>
          <div class="divOpciones">
            <div class="divWhatsapp">
                <p class="subtitulo">contáctanos por whatsapp</p>
                <a 
                  href="https://web.whatsapp.com/send?phone=5491169508834&text=Hola%21%20Quiero%20cotizar%20un%20viaje%0D%0A"
                  target="_blank" 
                  class="boton">cotiza ya</a>
                  <hr>
            </div>
            <div class="divEmail">
              <p class="subtitulo">envianos un correo</p>
              <form v-on:sumbit.prevent="EnviarForm">
                <label for="nombre">Nombre: </label>
                <input type="text" id="nombre" required>
  
                <label for="email">Email: </label>
                <input type="email" id="email" required>
  
                <label for="text">Mensaje: </label>
                <textarea name="txt" id="text" rows="10"></textarea>
  
                <button class="boton">Enviar</button>
              </form>
              <hr>
            </div>
          </div>
        </div>
    </div>
    
  </template>
  
  <script>
  export default {
    data(){
        return{

        }
    }
  };
  </script>

<style scoped> 	

/* DIVS */

.divCentro {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: flex-start;
  height: 100vh; /* Altura completa de la ventana */
  background-color: slateblue;
  color: white;
  text-align: center;
  padding: 20px;
}

.divCabezera {
  margin-bottom: 30px;
}

.divOpciones {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
  width: 100%;
  gap: 10px;
  position: absolute;
  top: 8em;
}

.divWhatsapp{
  background: #fff;
  color: slateblue;
  border-radius: 8px;
  padding: 17px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  max-width: 250px;
  max-height: 130px;
  flex: 1 1 calc(40%); /* Toma el 45% del ancho disponible */
  text-align: center;
}

.divEmail {
  background: #fff;
  color: slateblue;
  border-radius: 8px;
  padding: 22px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  max-width: 250px;
  flex: 1 1 calc(40%); /* Toma el 45% del ancho disponible */
  text-align: left;
}

/* TITULOS */

.titulo{
  font-family: "Open Sans", sans-serif;
  font-size: 1.5em;
  text-transform: uppercase;
  color: white;
  position: relative;
  bottom: 2.5em;
  letter-spacing: 1.8px;
  background: linear-gradient(slateblue,white);
  -webkit-background-clip: text;
  color: transparent;  
}

.subtitulo {
  font-family:'Comic-Sans', cursive;
  text-transform: uppercase;
  font-size: 1em;
  margin: 20px 0;
}

/* CONTROLES */

.boton {
  display: inline-block;
  background-color: #4caf50;
  border: none;
  color: white;
  text-decoration: none;
  padding: 8px 15px;
  border-radius: 5px;
  font-size: 0.8em;
  font-family: "Open Sans", sans-serif;
  font-weight: bold;
  transition: background-color 0.3s ease;
  text-transform: uppercase;
}

.boton:hover {
  background-color: white;
  color: #4caf50;
  border:#4caf50 solid 1px
}

/* FORMULARIO */

label {
  font-size: 0.8em;
  margin-bottom: 5px;
}

input, textarea {
  width: 100%;
  padding: 8px;
  margin-top: 5px;
  margin-bottom: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 1em;
}

</style>