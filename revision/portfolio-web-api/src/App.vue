<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <nav class="navbar navbar-expand-lg bg-dark position-fixe">
    <div class="container-fluid">
      <a class="navbar-brand" href="/">Home</a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <a class="nav-link" href="/about">About</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="/collection">Collection</a>
          </li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              Dropdown
            </a>
            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
              <li><a class="dropdown-item" href="#">Action</a></li>
              <li><a class="dropdown-item" href="#">Another action</a></li>
              <li><hr class="dropdown-divider"></li>
              <li><a class="dropdown-item" href="#">Something else here</a></li>
            </ul>
          </li>
        </ul>
        <h2 id="time" style="color:aliceblue">00:00:00</h2>
        <form class="d-flex" role="search">
          <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
          <button class="btn btn-outline-success" type="submit">Search</button>
        </form>
      </div>
    </div>
  </nav>

  <!--div class="d-flex" >
        <div class="container-fluid" >
        <div class="row " style="height:862px">
            <div class="col-2 contacts-table">
              <img class="photo" alt="100x100" src="@/assets/Foto3.jpg" data-holder-rendered="true">
                <div class="container">
                  <div class="row border">
                    <div class="col-9 normal-text">
                      <p class="anchor2"> </p>
                      <p class="first-highlight"> Maroš </p>
                      <p class="first-highlight"> Bednár </p>
                    </div>
                  </div>
                  <div class="row border">
                    <div class="col normal-text">
                      <p class="anchor2"> </p>
                      <p class="first-highlight"> bednarmaros341@gmail.com </p>
                    </div>
                  </div>
                  <div class="row border">
                    <div class="col normal-text">
                      <p class="anchor2"> </p>
                      <p class="first-highlight"> +421 911 670 188 </p>
                    </div>
                  </div>
                  <div class="row border">
                    <div class="col normal-text">
                      <a href="https://www.fiit.stuba.sk/" target="_blank" rel="noopener noreferrer">Where I study</a>
                    </div>
                  </div>
                  <div class="row border">
                    <div class="col normal-text">
                      <a href="https://www.doucma.sk/272129-doucovanie-programovanie-je-hracka" target="_blank" rel="noopener noreferrer">Where I teach</a>
                    </div>
                  </div>
                </div>
            </div>
            <div class="col-10 main-page">
              <center>
                <RouterView />
              </center>
            </div>
        </div>
    </div>
  </div-->


  <RouterView/>
  
</template>


<script lang="ts">
// cd ../app

setInterval(() => { document.getElementById("time")!.innerHTML = new Date().toLocaleTimeString('sk-SK')}, 100)

</script>


<!--style>
#time{
  padding-right: 15px;
  margin-top: 5px;
}

.photo{
  padding-bottom: 50px;
  border-radius: 150px;
  margin-left: 5%;
  margin-top: 10px;
}

.contacts-table{
  background-color: rgba(214, 214, 214, 0.586);
}

.normal-text{
  font-size: 18px;
  color: rgb(0, 61, 174);
  font-weight: 600;
}

a{
  color: rgba(0, 61, 174);
  text-decoration-style: solid;
}

a:hover{
  color: rgb(0, 145, 255);
  text-transform: capitalize;
}

p{
  display: inline;
}

.main-page{
  background-color: rgba(114, 114, 114, 0.606);
}

.first-highlight:hover{
  color: rgb(0, 153, 255);
  font-size: 22px;
}

.anchor2{
  font-size: 22px;
}

</style-->
