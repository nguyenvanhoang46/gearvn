import request from "../../lib/request"

// Product

export const getTableProductApi = () => request.get("/Admin/Product/GetProducts").then(({ data }) => data.data);

export const getProductApi = (id) => request.get(`/Admin/Product/GetProduct/${id}`).then(({ data }) => data.data);

export const createProductApi = (data) => request.post("/Admin/Product/SaveProduct", data).then(({data}) => data.data);

export const deleteProductApi = (id) => request.delete(`/Admin/Product/DeleteProduct/${id}`).then(({ data }) => data.data);

export const updateProductApi = (id, data) => request.put(`/Admin/Product/UpdateProduct/${id}`, data).then(({ data }) => data.data);
// export const deleteCtegoryApi = (id) => request.delete(`/Admin/Category/DeleteCategory/${id}`).then(({ data }) => data.data);
export const getProduct = () => request.get("/Product/GetProducts").then(({data}) => data.data);

export const ImageProduct = (formData) => request.post('/Admin/Image/UploadImage', formData).then(({data}) => data.data);

// User

export const getTableUserApi = () => request.get("/Admin/User/User").then(({ data }) => data.data);

export const createUserApi = (data) => request.post("/Admin/User/CreateUser", data).then(({ data }) => data);

export const deleteUserApi = (id) => request.delete(`/Admin/User/DeleteUser/${id}`).then(({ data }) => data.data);

export const getUserApi = (id) => request.get(`/Admin/User/User/${id}`).then(({ data }) => data.data);

export const updateUserApi = (id, data) => request.put(`/Admin/User/UpdateUser/${id}`, data).then((data) => data);

// Category

export const getTableCategoryApi = () => request.get("/Admin/Category/GetCategories").then(({ data }) => data.data);

export const deleteCategoryApi = (id) => request.delete(`/Admin/Category/DeleteCategory/${id}`).then(({ data }) => data.data);

export const createCategoryApi = (data) => request.post('/Admin/Category/SaveCategory', data).then(({ data }) => data);

export const getCategoryApi = (id) => request.get(`/Admin/Category/GetCategory/${id}`).then(({ data }) => data.data);

export const updateCategoryApi = (id, data) => request.put(`Admin/Category/UpdateCategory/${id}`, data).then((data) => data);