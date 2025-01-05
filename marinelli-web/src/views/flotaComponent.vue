<template>
    <section class="vehiculos">
      <!-- Fiori -->
       <img src="../assets/fiorino.png" alt="fiori" id="fiorino" >
      <div class="vehiculo">
        <div class="descripcion">
          <h2 class="titulo">Fiat Fiorino</h2>
          <p>
            Camioneta de carga con capacidad máxima de 800 kg. La caja tiene <strong>1,8 metros de largo, 1,2 metros de ancho y 1,3 metros de alto</strong>.
            Puede realizar tareas de tipo encomiendas, transporte de persona particular, y logística en conjunto con alguna empresa.
          </p>
        </div>
      </div>
      
      <!-- Jumpy -->
      <div class="vehiculo">
        <img src="../assets/jumpy.png" alt="jumpy">
        <div class="descripcion">
          <h2 class="titulo">Citroen Jumpy</h2>
          <p>
            Camioneta de carga con capacidad máxima de 1300 kg (1.3 toneladas). Las medidas de la caja son <strong>2 metros de largo, 1,6 metros de ancho y 1,4 metros de alto</strong>.
            Ideal para mudanzas de tamaño mediano a grande y transporte de mercancías o personas.
          </p>
        </div>
      </div>
    </section>
  </template>
  
  <script>
  export default {
  }
  </script>

  <style scoped> 
  
  .vehiculos {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 50px;
  }
  
 
  .vehiculo {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    margin: 20px 0;
    width: 70%;
    max-width: 1000px;
    background-color: white;
    border-radius: 8px;
    box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
    padding: 20px;
    color: black;
  }
  
  
  img {
    width: 300px;
    height: auto;
    border-radius: 8px;
  }
  
 
  .descripcion {
    max-width: 600px;
    margin-left: 20px;
  }
  
  .titulo {
    font-family: "Open Sans", sans-serif;
    font-size: 1.5em;
    color: slateblue;
    margin-bottom: 15px;
  }
  
  p {
    font-family: "Open Sans", sans-serif;
    font-size: 1em;
    line-height: 1.6;
  }
  
  strong {
    color: slateblue;
    font-weight: 800;
  }

  #fiorino{
    position: absolute;
    right: 10em;
  }
  
  </style>