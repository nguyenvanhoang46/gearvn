import request from "../../lib/request"


// Product

export const getTableProductApi = (data) => request.get("/Admin/Product/GetProducts").then(({data}) => data.data);

export const deleteProductApi = (id) => request.delete(`/Admin/Product/DeleteProudct/${id}`).then(({data}) => data.data);

// User

export const getTableUserApi = () => request.get("/Admin/User/User").then(({data}) => data.data);

export const createUserApi = (data) => request.post("/Admin/User/CreateUser", data).then(({data}) => data); 

export const deleteUserApi = (id) => request.delete(`/Admin/User/DeleteUser/${id}`).then(({data}) => data.data); 

export const getUserApi = (id) => request.get(`/Admin/User/User/${id}`).then(({data}) => data.data);

export const updateUserApi = (id, data) => request.put(`/Admin/User/UpdateUser/${id}`, data).then((data) => data);

// Category

export const getTableCategoryApi = () => request.get("/Admin/Category/GetCategories").then(({data}) => data.data);

export const deleteCategoryApi = (id) => request.delete(`/Admin/Category/DeleteCategory/${id}`).then(({data}) => data.data); 