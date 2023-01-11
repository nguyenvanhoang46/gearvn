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
import CreateProduct from "../admin/Product/CreateProduct";
import EditProduct from "../admin/Product/EditProduct";
import Cart from "../components/Cart";

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
        path: "adminlogin",
        element: <AdminLogin />,
    },
    {
        path: "adminsignup",
        element: <AdminSignUp />,
    },
    // Product 
    {
        path: "tableproduct",
        element: <TableProduct />,
    },
    {
        path: "addproduct",
        element: <CreateProduct />,
    },
    {
        path: "editproduct",
        element: <EditProduct />,
    },

    // User
    {
        path: "tableuser",
        element: <TablesUser />,
    },
    {
        path: "adduser",
        element: <CreateUser />,
    },
    
    {
        path: "edituser/:id",
        element: <EditUser />,
    },
    // Category
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
    {
        path: "cart",
        element: <Cart />,
    },


]);

export default router;