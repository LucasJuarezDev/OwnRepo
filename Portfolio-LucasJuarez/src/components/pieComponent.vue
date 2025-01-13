<template>
  <div>
    <hr id="divisoraInferior">
    <div id="copy">
      <h1>© Lucas Juarez.</h1>
    </div>
    <div id="redes">
      <a href="https://github.com/LucasJuarezDev/OwnRepo" target="blank"> <img src="../assets/github.png" alt="git" class="img"> </a>
      <a href="https://www.linkedin.com/in/lucas-juarez-366992210/" target="blank"> <img src="../assets/linkedin.png" alt="lnk" class="img"> </a>
      <a href="https://www.instagram.com/lucas_martin2_0/" target="blank"> <img src="../assets/ig.png" alt="ig" class="img"> </a>
    </div>
  </div>
</template>

<script>
export default {

}
</script>

<style scoped>
#copy{
  display: inline-flex;
  position: relative;
  font-size: 9px;
  text-align: center;
}
#redes{
  display: inline;
  position: relative;
  left: 30em;
}
.img{
  width: 25px; 
  height: 25px; 
  margin-left: 2em;
}

#divisoraInferior{
  margin: 15px;
}

.img:hover{
  width: 28px;
  height: 28px;
  border-radius: 10px;
  object-fit: cover; /* Ajusta la imagen sin deformarla */
  transition: transform 0.3s ease, box-shadow 0.3s ease; 
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.2); 
}
</style>