import React from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link } from "react-router-dom";

const CreateUser = () => {
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
              <div className=" p-6 overflow-x-scroll px-0 pt-0 pb-2">
                <form action="" method="post">
                  <div className=''>
                    <div className="">
                      <label htmlFor="">UserName</label>
                    </div>
                    <input type="text" placeholder='UserName' />
                  </div>
                  <div className=''>
                    <div className="">
                      <label htmlFor="">FirstName</label>
                    </div>
                    <input type="text" placeholder='UserName' />
                  </div>
                  <div className=''>
                    <div className="">
                      <label htmlFor="">UserName</label>
                    </div>
                    <input type="text" placeholder='UserName' />
                  </div>
                  <div className=''>
                    <div className="">
                      <label htmlFor="">LastName</label>
                    </div>
                    <input type="text" placeholder='UserName' />
                  </div>
                  <div className=''>
                    <div className="">
                      <label htmlFor="">Phone</label>
                    </div>
                    <input type="text" placeholder='UserName' />
                  </div>
                  <div className=''>
                    <div className="">
                      <label htmlFor="">Email</label>
                    </div>
                    <input type="text" placeholder='UserName' />
                  </div>
                  <div className=''>
                    <div className="">
                      <label htmlFor="">Role</label>
                    </div>
                    <input type="text" placeholder='UserName' />
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

export default CreateUser