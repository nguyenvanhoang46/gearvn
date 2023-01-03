import request from "../../lib/request"


// Product

export const getTableProductApi = (data) => request.get("/Admin/Product/GetProducts").then(({data}) => data.data);

export const deleteProductApi = (id) => request.delete(`/Admin/Product/DeleteProudct/${id}`).then(({data}) => data.data);

// User

export const getTableUserApi = () => request.get("/Admin/User/User").then(({data}) => data.data);

export const createUserApi = (data) => request.post("/Admin/User/CreateUser", data).then(({data}) => data); 

export const deleteUserApi = (id) => request.delete(`/Admin/User/DeleteUser/${id}`).then(({data}) => data.data); 

export const editUserApi = (id) => request.put(`/Admin/User/UpdateUser/${id}`).then(({data}) => data);

