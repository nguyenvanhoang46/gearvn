import { faColonSign } from '@fortawesome/free-solid-svg-icons';
import React, { useEffect, useState } from 'react';
import { Link, useNavigate, useParams } from "react-router-dom";
import { getProductApi, getTableCategoryApi, updateProductApi } from '../../app/services/adminService';
import Navbar from '../Navbar';
import NavbarTop from '../NavbarTop';
const EditProduct = () => {

  const { id } = useParams();

  const [data, setData] = useState([]);
  const [image, setImage] = useState("");
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");
  const [quantity, setQuantity] = useState("");
  const [category, setCategory] = useState("");
  const [salePrice, setSalePrice] = useState("");
  const [description, setDescription] = useState("");
  const [content, setContent] = useState("");
  const [categories, setCategories] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {

    (async () => {
      const { data } = await getTableCategoryApi();
      if (data) {
        setCategories(data);
      }
    })()

  }, [])

  useEffect(() => {
    const getProduct = async (id) => {
      try {
        const data = await getProductApi(id);
        setImage(data.image);
        setName(data.name);
        setPrice(data.price);
        setQuantity(data.quantity);
        setCategory(data.category);
        setSalePrice(data.salePrice);
        setDescription(data.description);
        setContent(data.content);
      } catch (error) {
        console.log(error.message);
      }
    }
    getProduct(id);
  }, [])


  const handleEditProduct = async (e) => {
    e.preventDefault();
    const request = {
      image,
      name,
      price,
      quantity,
      categoryId: category.id == null ? category: category.id,
      salePrice,
      description,
      content
    }
    try {
      console.log("req", request);
      const update = await updateProductApi(id, request);
      console.log("editpro", update);
      navigate('/tableproduct');
    } catch (error) {
      console.log(error.message);
    }
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
                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Add User</h6>
              </div>
              <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                <form onSubmit={handleEditProduct} >
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
                      <div className='w-[60%]'>
                        <select name="" id="" value={category.id} onChange={(e) => setCategory(e.target.value)} >
                          {
                            categories?.map((category, _) => {
                              if (category.id === category.id)
                                return <option value={category.id} selected>{category.name}</option>
                              else
                                return <option value={category.id}>{category.name}</option>
                            })
                          }
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
                          {/* <input value={image} onChange={(e) => setImage(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Image" /> */}
                          <input type="file" className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' placeholder="Image" />
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

export default EditProduct