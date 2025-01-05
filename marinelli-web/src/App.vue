<template>
  <div>
    <headerComponent></headerComponent>
    <router-view></router-view>
  </div>
</template>

<script>
import headerComponent from './components/headerComponent.vue';
export default {
  components:{headerComponent}
}
</script>

<style>

</style>
