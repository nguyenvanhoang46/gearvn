import {
    createBrowserRouter,
    RouterProvider,
    useParams,
} from "react-router-dom";
import AdminLogin from "../admin/Login";
import Navbar from "../admin/Navbar";
import TableProduct from "../admin/Product/TableProduct";
import TableCategory from "../admin/Category/TableCategory";
import AdminSignUp from "../admin/SignUp";
import CreateUser from "../admin/User/CreateUser";
import EditUser from "../admin/User/EditUser";
import TablesUser from "../admin/User/TablesUser";
import App from "../App";
import Login from "../components/Login";
import ProductDetail from "../components/ProductDetail";
import Register from "../components/Register";
import CreateCategory from "../admin/Category/CreateCategory";
import EditCategory from "../admin/Category/EditCategory";

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
    {
        path: "edituser/:id",
        element: <EditUser />,
    },
    {
        path: "tablecategory",
        element: <TableCategory />,
    },
    {
        path: "addcategory",
        element: <CreateCategory />,
    },
    {
        path: "editcategory/:id",
        element: <EditCategory />,
    },

  
]);

export default router;