import axios from 'axios';

const BASE_URL = "http://localhost:5000/api"

const request = axios.create({
    baseURL: BASE_URL,
})

request.interceptors.request.use(async (config) => {
    const token = localStorage.getItem("token");
    config.headers.Authorization =  `Bearer ${token}`;
    return config;
}, (error) => Promise.reject(error))


export default request;