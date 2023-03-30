import { data } from "autoprefixer";
import request from "../../lib/request"

// Order

export const createOrderApi = (data) => request.post('/Order/CreateOrder', data).then(({ data }) => data.data);

export const getOrderApi = (data) => request.get('/Order/GetOrders').then(({data}) => data.data);


