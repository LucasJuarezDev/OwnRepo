<template>
    <div>
      <body>
        <div class="divContenedores" id="posMision" @mouseover="OcultarMision = true" @mouseleave="OcultarMision = false">
          <h1 class="titulo">misión</h1>
          <p v-if="OcultarMision">
            Ofrecer soluciones integrales de transporte y logística que se adapten a las necesidades de nuestros clientes, 
            garantizando un servicio seguro, confiable y eficiente. Nuestro objetivo es <strong>construir relaciones de confianza 
              basadas en la calidad, puntualidad y compromiso</strong>, contribuyendo al crecimiento de las empresas y particulares que confían 
            en nosotros.
          </p>
        </div>
        <div class="divContenedores" id="posVision" @mouseover="OcultarVision = true" @mouseleave="OcultarVision = false">
          <h1 class="titulo">visión</h1>
          <p v-if="OcultarVision">
            Ser la empresa de fletes líder en el Buenos Aires, reconocida por nuestra excelencia en el servicio, 
            innovación tecnológica y compromiso con el medio ambiente. Aspiramos a expandir nuestra presencia 
            en toda la provincia, destacándonos como un socio estratégico en el transporte y la logística para pequeñas y grandes empresas.
          </p>
        </div>
        <div class="divContenedores" id="posObjetivo" @mouseover="OcultarObjetivos = true" @mouseleave="OcultarObjetivos = false">
          <h1 class="titulo">objetivos</h1>
          <p v-if="OcultarObjetivos">
            Buscamos, entre otras cosas, incrementar la satisfacción del cliente con 
            encuestas de retroalimentación y optimización de procesos, ampliar nuestra flota de vehículos para ofrecer mayor capacidad y 
            flexibilidad en los servicios, y expandir los servicios a nivel regional o nacional, ganando prestigio y confianza entre los clientes
            de siempre y los nuevos que conozcan nuestra marca.
          </p>
        </div>
      </body>
      <footer>
        <div class="PiePagina">
          <div class="divFooter Logo">
            <img src="../assets/logomarinelli.png" alt="logo.png">
          </div>
          <div class="divFooter Contacto">
            <h2 class="tituloContacto">Contacto</h2>
            <ul>
              <li>11-6950-8834</li>
              <li>marinelli99125@yahoo.com</li>
            </ul>
          </div>
          <div class="divFooter Instagram">
            <h2 class="tituloIg">Seguinos en Instagram</h2>
            <a href="https://www.instagram.com/fletesmarinelli/" target="blank"> <img src="../assets/Instagram.png" alt="ig.png" id="ig"> </a>
            
          </div>
        </div>
      </footer>
    </div>
  </template>
  
  <script>
  export default {
      data(){
          return{
              OcultarMision: false,
              OcultarVision: false,
              OcultarObjetivos: false,
          }
      }
  }
  </script>
  
  <style scoped>

  /* BASE */
  footer{
    background: slateblue;
    padding: 10px;
  }
  body{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
  }
  
  /* CUERPO DE PAGINA */
  #posMision{
    position: absolute;
    top: 15%;
    right: 30%;
  }
  
  #posVision{
    position: relative;
    top: 30%;
    left: 21%;
  }
  
  #posObjetivo{
    position:relative;
    right:25%;
  }
  
  .divContenedores{
    width: 80%;
    max-width: 600px;
    border-radius: 8px;
    box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
    padding: 20px;
    color: black;
  }
  
  .titulo{
    font-family:Arial, Helvetica, sans-serif;
    font-size: 40px;
    text-transform: uppercase;
    margin-bottom: 20px;
    color: slateblue; 
  }
  
  p{
    font-family: 'Times New Roman', Times, serif;
    text-transform: capitalize;
    font-size: 17px;
    line-height: 1.6;
    color:slateblue;
  }
  
  /* PIE DE PAGINA */
  #ig{
    width: 100px;
    height: auto;
    margin-left: 100px;
  }
  img{
    width: 50%;
    margin-bottom: 20px;
  }
  
  li{
    list-style: none;
    margin-bottom: 10px;
    margin-right: 45px;
    font-family: "Open Sans", sans-serif;
    font-weight: 700;
    color: white;
  }
  
  
  .tituloContacto{
    color: white;
    text-decoration: none;
    text-transform: uppercase;
    font-family: "Open Sans", sans-serif;
    margin-bottom: 30px;
  }
  .tituloIg{
    color: white;
    text-decoration: none;
    text-transform: uppercase;
    font-family: "Open Sans", sans-serif;
  }
  
  
  .PiePagina{
    display: flex; 
    justify-content: space-between; 
    align-items: center; 
    flex-wrap: wrap; 
  }
  
  .divFooter.Contacto{
    text-align: center; 
    padding: 10px;
  }
  
  
  </style>