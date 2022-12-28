import request from "../../lib/request"


export const getTableProductApi = () => request.get("/Admin/Product/GetProducts").then(({data}) => data.data);
