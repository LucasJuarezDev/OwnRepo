<template>
  <div class="contenedorPrincipal">
    <header><cabezaComponent></cabezaComponent> </header>
    <div class="inicioContent">
      <h1 id="tituloSeccion">Contacto</h1>
      <hr>
      <div class="contactoContent">
        <div class="emailContent">
          <form v-on:submit.prevent="EnviarForm">
            <label for="email" id="textoEmail">Email: </label>
            <input type="email" id="email" required placeholder="email..." v-model="email">

            <label for="mensaje">Mensaje: </label>
            <textarea name="txt" id="mensaje" rows="10" placeholder="deje el mensaje..." v-model="cuerpoEmail"></textarea>

            <button class="botonEmail">Enviar</button>
          </form>
        </div>
      </div>
      <div class="contactoContent">
        <div class="cvContent">
          <h1 id="textoCV">Curriculum Vitae</h1>
          <div class="btnContaint">
            <a href="/CVJuarezLucasMartin.pdf" target="_blank"> 
              <button class="botonEmail" id="btnCV">Vista Previa</button> 
            </a>
        
            <a href="/CVJuarezLucasMartin.pdf" download> 
              <button class="botonEmail" id="btnCV">Descargar</button> 
            </a>
          </div>
        </div>
      </div>
    </div>
    <footer> <pieComponent></pieComponent> </footer>
  </div>
</template>

<script>
import cabezaComponent from '@/components/cabezaComponent.vue';
import pieComponent from '@/components/pieComponent.vue';

export default {
    components:{cabezaComponent, pieComponent},
    data(){
      return{
        email: "",
        cuerpoEmail: "",
      }
    },
    methods:{
      async EnviarForm(){
        try
        {
          const response = await fetch("http://localhost:3000",{
          method:"POST",
          headers:{
            "Content-Type":"application/json"
          },
          body:JSON.stringify({
            email:this.email,
            cuerpoEmail:this.cuerpoEmail,
            }),
          });

          if(response.ok){
            this.email = "";
            this.cuerpoEmail = "";
            alert("ENVIADO!!!!");
          }
        }
        catch(error)
        {
          console.error("Error:", error);
          alert("Hubo un problema con la solicitud");
        }
      }
    }
}
</script>

<style scoped>
.ContenedorPrincipal{
  display: flex;
  flex-direction: column;
  min-height: 100vh; /* Ocupa toda la altura de la ventana */
  margin: 0;
}
header {
  background: rgb(76, 78, 197);
  color: white;
  text-align: center;
  padding: 10px 0;
}

.inicioContent {
  flex: 1; /* Ajusta dinámicamente el tamaño del contenido */
  background: rgb(76, 78, 197);
  color: white;
  padding: 20px;
}

footer {
  background: rgb(76, 78, 197);
  color: white;
  text-align: center;
  padding: 10px 0;
}

.contactoContent{
  display: inline-block;
  flex-direction: row;
  justify-content: space-around;
  flex-wrap: wrap;
  background-color: rgb(191, 192, 235);
  color: rgb(76, 78, 197);
  padding: 10px;
  width: 30%;
  height: 50%;
  border-radius: 20px;
  margin-bottom: 30px;
  margin-left: 7em;
}

.emailContent{
  display: flex;
  flex-direction: column; 
  align-items: center;    
  justify-content: center; 
  text-align: center;   
  padding: 10px 20px 0 0;
  gap: 5px; 
}

.cvContent{
  display: flex;
  flex-direction: column; 
  align-items: center;    
  justify-content: center; 
  text-align: center;     
  gap: 5px;          
}

#tituloSeccion{
  text-align: center;
  text-transform: uppercase;
  position: relative;
  bottom: 1.2em;
  font-size: 3em;
}

hr{
  margin: 0 100px;
  position: relative;
  bottom: 5.5em;
}

#textoEmail {
  font-size: 1.2em;
  margin-bottom: 5px;
}

#email, #mensaje {
  width: 100%;
  padding: 8px;
  margin-top: 5px;
  margin-bottom: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 1em;
}

.botonEmail{
  background-color: #300fe7;
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
  margin-left: 20px;
}

.botonEmail:hover{
  background-color: white;
  color: #300fe7;
}

#textoCV{
  font-size: 1.5em;
  margin-bottom: 20px;
  letter-spacing: 2px;
  text-transform: uppercase;
}

.btnContaint{
  display: flex;
  flex-direction: column;
  gap: 5px;
  justify-content: center;
}

#btnCV{
  margin: 0 0 20px 10px;
}

</style>