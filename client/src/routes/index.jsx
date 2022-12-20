import {
    createBrowserRouter,
    RouterProvider,
} from "react-router-dom";
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
]);

export default router;