import request from "../../lib/request"

// Order

export const createOrderApi = (data) => request.post('/Order/CreateOrder', data).then(({data}) => data.data);