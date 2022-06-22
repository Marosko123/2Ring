<template>
    <div class="d-flex justify-content-center bg-light">
        <nav class="navbar navbar-expand-lg" >
            <div class="container-fluid">
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <router-link to="/" id="router" class="nav-link active" aria-current="page"> Actual employees </router-link>
                        </li>
                        <li class="nav-item">
                            <router-link to="/PreviousEmployees" id="router" class="nav-link active" aria-current="page"> Previous employees </router-link>
                        </li>
                        <li class="nav-item">
                            <router-link to="/Positions" id="router" class="nav-link active" aria-current="page"> Positions </router-link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
    
    <div id="app" class="bg-image" style="background-image: url('https://wallpaperaccess.com/full/4584345.png'); ">
        <div id="time-container" class="container" style="max-width:20%">
            <h1 id="time"></h1>
        </div>
        <router-view></router-view>
    </div>
</template>

<style>

#app {
    font-family: Palatino, URW Palladio L, serif;
    font-size: 140%;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoWothing: grayscale;
    text-align: center;
    color: #0000ff;
    background-size: cover;
    min-height: 993px;
}

#router:hover {
    color: rgb(16, 104, 255);
    background-color:rgb(70, 237, 181);

}
#router{
    background-color:rgb(121, 255, 210);
    margin: 2px;
    color: rgb(0, 0, 0);
    border-radius: 8px;
    padding-left: 25px;
    padding-right: 25px;
    padding-top: 5px;
    padding-bottom: 5px;
}
#time{
    padding-top: 15px;
    color: #000;
}
#time-container{
    background-color: rgba(0, 255, 174, 0.357);
    border-radius: 15px;
    padding-bottom: 3px;
    padding-top: 3px;
    margin-bottom: 0px;
    margin-top: 0px;
}
</style>
  
<script setup lang="ts">
timer();

function timer(){
    setInterval(displayTime, 1000)
}

function displayTime(){
    let d = new Date();

    document.getElementById("time")!.innerHTML = String(d.getHours()).padStart(2, '0') + ":" 
    + String(d.getMinutes()).padStart(2, '0') + ":" + String(d.getSeconds()).padStart(2, '0')
}

</script>
