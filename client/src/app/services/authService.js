
import request from "../../lib/request"

export const postLoginApi = (data) => request.post("/Auth/Login", data).then(({ data }) => data.data);

export const getMeApi = () => request.get("/Auth/Me").then(({data}) => data.data);


export const postRegister = (data) => request.post("/Auth/Register", data).then(({data}) => data.data);



