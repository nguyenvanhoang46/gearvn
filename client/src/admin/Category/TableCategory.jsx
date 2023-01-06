import React from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link } from "react-router-dom";
import { useState, useEffect } from 'react';
import { deleteCategoryApi, getTableCategoryApi } from '../../app/services/adminService';

const TableCategory = () => {

  const [dataCategory, setDataCategory] = useState([]);

  useEffect(() => {
    const getAllCategory = async () => {
      try {
          const data = await getTableCategoryApi();
          setDataCategory(data.data);
          console.log(data);
      } catch (error) {
          console.log(error.message);
      }
    }
    getAllCategory();
  }, []);

  const handleDelete = async (id) => {
    try {
      const deleteCategory = await deleteCategoryApi(id);
      console.log(deleteCategory);
      setDataCategory(
        dataCategory.filter((post) => {
          return post.id != id;
        }));
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
                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>User</h6>
                <Link to='/addcategory' className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Add Category</Link>
              </div>
              <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                <table className='w-full min-w-[640px] table-auto'>
                  <thead>
                    <tr>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Name</p>
                      </th>
                      <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Action</p>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {dataCategory.map((item, index) => {
                      return (
                        <tr key={index}>
                          <td className='py-3 px-5'>{item.name}</td>
                          <td className='py-3 px-5 flex gap-3'>
                            <Link to={`/editcategory/${item.id}`}>Sửa</Link>
                            <button onClick={() => handleDelete(item.id)}>Xóa</button>
                          </td>
                        </tr>
                      );
                    })}
                  </tbody>
                </table>
              </div>
            </div>
            <h2 className='ml-4'>Số lượng {dataCategory.length}</h2>
          </div>
        </div>
      </div>
    </>
  )
}

export default TableCategory