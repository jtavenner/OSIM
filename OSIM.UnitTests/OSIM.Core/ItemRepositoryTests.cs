using System;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace OSIM.UnitTests.OSIM.Core
{
    public class when_working_with_the_item_type_repository : Specification
    {
    }

    public class and_saving_a_valid_item_type : 
        when_working_with_the_item_type_repository
    {
        private int _result;
        private ItemTypeRepository _itemRepository;
        private ItemType _testItemType;
        private int _itemTypeId;

        protected override void Because_of()
        {
            _result = _itemRepository.Save(_testItemType);
        }


        [Test]
        public void then_a_valid_item_type_id_should_be_returned()
        {
            _result.ShouldEqual(_itemTypeId);
        }
    }
}
