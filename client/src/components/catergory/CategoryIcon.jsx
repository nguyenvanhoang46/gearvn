import React from 'react'

const CategoryIcon = ({icon, label}) => {
  return (
    <div>
        <div className='hover:bg-[#ea1c00] hover:text-[white] hover:border-[#ea1c00] border-[1px] p-[6px] flex gap-2 items-center justify-center text-[12px] font-medium uppercase border-[#505050] rounded-md'>
            {icon}
            {label}
        </div>
    </div>
  )
}

export default CategoryIcon