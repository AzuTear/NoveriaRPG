import { createMemoryHistory, createRouter } from 'vue-router'

const router = createRouter({
  history: createMemoryHistory(import.meta.env.BASE_URL),
  routes: [
    {
        path: '/',
        name: 'home',
        component: () => import("../views/HomeView.vue"),
    },
    {
        path: '/profile',
        name: 'profile',
        component: () => import("../views/ProfileView.vue"),
    },
  ],
});

  export default router;
