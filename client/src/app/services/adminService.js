import request from "../../lib/request"


export const getTableProductApi = () => request.get("/Admin/Product/GetProducts").then(({data}) => data.data);

export const getTableUserApi = () => request.get("/Admin/User/User").then(({data}) => data.data);
