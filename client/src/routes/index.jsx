import {
    createBrowserRouter,
    RouterProvider,
} from "react-router-dom";
import AdminLogin from "../admin/Login";
import Navbar from "../admin/Navbar";
import TableProduct from "../admin/Product/TableProduct";
import AdminSignUp from "../admin/SignUp";
import CreateUser from "../admin/User/CreateUser";
import TablesUser from "../admin/User/TablesUser";
import App from "../App";
import Login from "../components/Login";
import ProductDetail from "../components/ProductDetail";
import Register from "../components/Register";

const router = createBrowserRouter([
    {
        path: "/",
        element: <App />,
    },
    {
        path: "/register",
        element: <Register />,
    },
    {
        path: "login",
        element: <Login />,
    },
    {
        path: "home",
        element: <App />,
    },
    {
        path: "productdetail",
        element: <ProductDetail />,
    },
    {
        path: "navbar",
        element: <Navbar />,
    },
    {
        path: "tableproduct",
        element: <TableProduct />,
    },
    {
        path: "tableuser",
        element: <TablesUser />,
    },
    {
        path: "adduser",
        element: <CreateUser />,
    },
    {
        path: "adminlogin",
        element: <AdminLogin />,
    },
    {
        path: "adminsignup",
        element: <AdminSignUp />,
    },
  
]);

export default router;