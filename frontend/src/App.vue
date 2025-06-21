<script setup lang="ts">
import { RouterLink, RouterView } from "vue-router";
import Button from 'primevue/button';
</script>

<template>
  <header>
    <nav>
      <div class="flex gap-3 justify-center">
        <Button>
          <RouterLink to="/">Home</RouterLink>
        </Button>
        <Button>
          <RouterLink to="/profile">Profile</RouterLink>
        </Button>
      </div>
    </nav>
  </header>
  
  <RouterView />
</template>

<style scoped>
</style>
