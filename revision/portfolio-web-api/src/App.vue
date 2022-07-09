<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <nav class="navbar navbar-expand-lg bg-dark">
    <div class="container-fluid">
      <a class="navbar-brand" href="/">Maroš</a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <!--div class="collapse navbar-collapse" id="navbarSupportedContent"-->
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <a class="nav-link" href="#services">Services</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#about">About</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#work">Collection</a>
          </li>
        </ul>
        <p class="time" id="time" style="color:aliceblue">00:00:00</p>
        <form class="d-flex" role="search">
          <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
          <button class="btn btn-outline-success" type="submit">Search</button>
        </form>
      </div>
    </div>
  </nav>

  <RouterView/>
  
</template>


<script lang="ts">

setInterval(() => { document.getElementById("time")!.innerHTML = new Date().toLocaleTimeString('sk-SK')}, 100)

</script>


<style>
.time {
  display: none;
  color: red;
  font-size: 1.5em;
  padding: 0;
  margin: auto;
}
</style>