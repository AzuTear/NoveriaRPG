import './style.css';
import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import PrimeVue from 'primevue/config';
import Aura from '@primeuix/themes/aura';
import axios from 'axios';

const app = createApp(App);

app.use(router);
app.use(axios);
app.use(PrimeVue, {
    theme: {
        preset: Aura
    }
});

app.mount('#app');
