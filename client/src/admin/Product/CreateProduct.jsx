import React from 'react'
import { useState, useEffect } from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link, useParams, useNavigate } from "react-router-dom";
import { createProductApi, ImageProduct, getCategoryP, getTableCategoryApi, getTableProductApi } from '../../app/services/adminService';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const CreateProduct = () => {

  const [data, setData] = useState([]);
  const [image, setImage] = useState("");
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");
  const [quantity, setQuantity] = useState("");
  const [categoryId, setCategoryId] = useState("");
  const [salePrice, setSalePrice] = useState("");
  const [description, setDescription] = useState("");
  const [content, setContent] = useState("");
  const navigate = useNavigate();


  useEffect(() => {
    const getAllCategory = async () => {
      const data = await getTableCategoryApi();
      setData(data.data);
      console.log(data);
    }
    getAllCategory();
  }, []);


  const handleCreateProduct = async (e) => {
    e.preventDefault();
    try {
      const data = await createProductApi({ name, price, quantity, categoryId, salePrice, description, content, image });
      const formData = new FormData();
      formData.append('image', image);
      formData.append('id', data.id);
      await ImageProduct(formData);
      toast.success(`Thêm sản phẩm thành công`, {
        position: "top-right",
        autoClose: 5000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: undefined,
        theme: "light",
    });
      navigate('/tableproduct');

    } catch (error) {
      console.log(error.message);
    }
  }

  const handleImage = (e) => {
    // console.log("file", e.target.files[0]);
    setImage(e.target.files[0]);
  }
  return (
    <>
      <div className="bg-[#eceff1] min-h-[1070px]">
        <div className="grid grid-cols-12  ">
          <div className="col-span-2">
            <Navbar />
          </div>
          <div className="col-span-10">
            <div className="mt-5"><NavbarTop /></div>
            <div className="relative flex flex-col bg-clip-border rounded-xl bg-white text-gray-700 shadow-md mt-12 mb-8  gap-12">
              <div className="relative flex justify-between bg-clip-border mx-4 rounded-xl overflow-hidden bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-blue-500/40 shadow-lg -mt-6  p-6">
                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Add Product</h6>
              </div>
              <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                <form onSubmit={handleCreateProduct} >
                  <div className="ml-10">
                    <div className="gap-6 mt-5 items-center">
                      <div className="flex gap-6 mt-4 items-center">
                        <label className='font-medium text-[14px] w-[10%] '>Name</label>
                        <div className='w-[60%]'>
                          <input value={name} onChange={(e) => setName(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Name" />
                        </div>
                      </div>
                    </div>
                    <div className="flex gap-6 mt-7 items-center">
                      <label className='font-medium text-[14px] w-[10%] '>Price</label>
                      <div className='w-[60%]'>
                        <input value={price} onChange={(e) => setPrice(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Price" />
                      </div>
                    </div>
                    <div className="flex gap-6 mt-7 items-center">
                      <label className='font-medium text-[14px] w-[10%] '>Quantity</label>
                      <div className='w-[60%]'>
                        <input value={quantity} onChange={(e) => setQuantity(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Quantity" />
                      </div>
                    </div>
                    <div className="flex gap-6 mt-7 items-center">
                      <label className='font-medium text-[14px] w-[10%] '>salePrice</label>
                      <div className='w-[60%]'>
                        <input value={salePrice} onChange={(e) => setSalePrice(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="SalePrice" />
                      </div>
                    </div>
                    <div className="flex gap-6 mt-7 items-center">
                      <label className='font-medium text-[14px] w-[10%] '>Category</label>
                      <div className='w-[60%] focus:bg-[#fff] focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 '>
                        <select className='outline-none h-[37px] w-full pl-2' name="" id="" value={categoryId} onChange={(e) => setCategoryId(e.target.value)} >
                          {data.map((item) => {
                            return (
                              <option value={item.id}>{item.name}</option>
                            )
                          })}
                        </select>
                      </div>
                    </div>
                    <div className="flex gap-6 mt-7 items-center">
                      <label className='font-medium text-[14px] w-[10%] '>Description</label>
                      <div className='w-[60%]'>
                        <input value={description} onChange={(e) => setDescription(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Description" />
                      </div>
                    </div>
                    <div className="flex gap-6 mt-7 items-center">
                      <label className='font-medium text-[14px] w-[10%] '>Content</label>
                      <div className='w-[60%]'>
                        <input value={content} onChange={(e) => setContent(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Content" />
                      </div>
                    </div>
                    <div className="gap-6 mt-5 items-center">
                      <div className="flex gap-6 mt-4 items-center">
                        <label className='font-medium text-[14px] w-[10%] '>Chon File</label>
                        <div className='w-[60%]'>
                          <input type="file" onChange={handleImage} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' placeholder="Image" />
                        </div>
                      </div>
                    </div>
                    <div className="pl-[180px] pb-6 pt-20 flex gap-4">
                      <button type="submit" className="middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 px-6 rounded-lg bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] block ">Add Product</button>
                      <Link to='/tableproduct' type="submit" className="middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 px-6 rounded-lg bg-gradient-to-tr bg-[#EB5160] to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] block ">Cancel</Link>
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  )
}

export default CreateProduct